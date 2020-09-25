using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools.Utils;

namespace BlenderLikeSceneViewHotkeys.Editor
{
    public class SceneViewExtensionsTest
    {
        private readonly SceneView _sceneView = ScriptableObject.CreateInstance<SceneView>();
        private readonly Vector3EqualityComparer _comparer = new Vector3EqualityComparer(0.1f);

        [SetUp]
        public void ResetSceneView()
        {
            _sceneView.rotation = Quaternion.LookRotation(new Vector3(-1f, -0.7f, -1f));
            _sceneView.pivot = Vector3.zero;
            _sceneView.size = 10f;
            _sceneView.orthographic = false;
        }

        [Test]
        public void CheckDefaultProperties()
        {
            Assert.That(_sceneView.rotation.eulerAngles, Is.EqualTo(new Vector3(26.3f, 225f, 0f)).Using(_comparer));
            Assert.That(_sceneView.pivot, Is.EqualTo(new Vector3(0f, 0f, 0f)));
            Assert.That(_sceneView.size, Is.EqualTo(10f));
            Assert.That(_sceneView.orthographic, Is.EqualTo(false));
        }

        [Test]
        public void SetDirection_front()
        {
            _sceneView.SetDirection(Vector3.back);
            Assert.That(_sceneView.rotation.eulerAngles, Is.EqualTo(new Vector3(0f, 180f, 0f)));
        }

        [Test]
        public void SetDirection_right()
        {
            _sceneView.SetDirection(Vector3.right);
            Assert.That(_sceneView.rotation.eulerAngles, Is.EqualTo(new Vector3(0f, 90f, 0f)));
        }

        [Test]
        public void SetDirection_top()
        {
            _sceneView.SetDirection(Vector3.down);
            Assert.That(_sceneView.rotation.eulerAngles, Is.EqualTo(new Vector3(90f, 180f, 0f)));
        }

        [Test]
        public void SetDirection_bottom()
        {
            _sceneView.SetDirection(Vector3.up);
            Assert.That(_sceneView.rotation.eulerAngles, Is.EqualTo(new Vector3(270f, 180f, 0f)));
        }

        [Test]
        public void Orbit_left()
        {
            _sceneView.SetDirection(Vector3.forward);
            _sceneView.OrbitY(15f);
            _sceneView.OrbitY(15f); // call twice to make sure the rotations are added
            Assert.That(_sceneView.rotation.eulerAngles, Is.EqualTo(new Vector3(0f, 30f, 0f)).Using(_comparer));
        }

        [Test]
        public void Orbit_right()
        {
            _sceneView.SetDirection(Vector3.forward);
            _sceneView.OrbitY(-15f);
            _sceneView.OrbitY(-15f); // call twice to make sure the rotations are added
            Assert.That(_sceneView.rotation.eulerAngles, Is.EqualTo(new Vector3(0f, 330f, 0f)).Using(_comparer));
        }

        [Test]
        public void Orbit_up()
        {
            _sceneView.SetDirection(Vector3.forward);
            _sceneView.OrbitX(15f);
            _sceneView.OrbitX(15f); // call twice to make sure the rotations are added
            Assert.That(_sceneView.rotation.eulerAngles, Is.EqualTo(new Vector3(30f, 0f, 0f)).Using(_comparer));
        }

        [Test]
        public void Orbit_down()
        {
            _sceneView.SetDirection(Vector3.forward);
            _sceneView.OrbitX(-15f);
            _sceneView.OrbitX(-15f); // call twice to make sure the rotations are added
            Assert.That(_sceneView.rotation.eulerAngles, Is.EqualTo(new Vector3(330f, 0f, 0f)).Using(_comparer));
        }

        [Test]
        public void Orbit_x_and_y_axis()
        {
            _sceneView.SetDirection(Vector3.forward);
            _sceneView.OrbitX(15f);
            _sceneView.OrbitY(15f);
            Assert.That(_sceneView.rotation.eulerAngles, Is.EqualTo(new Vector3(15f, 15f, 0f)).Using(_comparer));
        }

        [Test]
        public void Orbit_y_and_x_axis()
        {
            _sceneView.SetDirection(Vector3.forward);
            _sceneView.OrbitY(15f);
            _sceneView.OrbitX(15f);
            Assert.That(_sceneView.rotation.eulerAngles, Is.EqualTo(new Vector3(15f, 15f, 0f)).Using(_comparer));
        }

        [Test]
        public void OppositeSide()
        {
            _sceneView.SetDirection(Vector3.forward);
            _sceneView.OppositeSide();
            Assert.That(_sceneView.rotation.eulerAngles, Is.EqualTo(new Vector3(0f, 180f, 0f)).Using(_comparer));
        }

        [Test]
        public void OppositeSide_topView_to_bottomView()
        {
            _sceneView.SetDirection(Vector3.down);
            _sceneView.OppositeSide();
            Assert.That(_sceneView.rotation.eulerAngles, Is.EqualTo(new Vector3(270f, 180f, 0f)));
        }

        [Test]
        public void OppositeSide_bottomView_to_topView()
        {
            _sceneView.SetDirection(Vector3.up);
            _sceneView.OppositeSide();
            Assert.That(_sceneView.rotation.eulerAngles, Is.EqualTo(new Vector3(90f, 180f, 0f)));
        }

        [Test]
        public void Roll_front_to_right()
        {
            _sceneView.SetDirection(Vector3.back);
            _sceneView.Roll(15f);
            Assert.That(_sceneView.rotation.eulerAngles, Is.EqualTo(new Vector3(0f, 180f, 15f)).Using(_comparer));
        }

        [Test]
        public void Roll_right_to_left()
        {
            _sceneView.SetDirection(Vector3.right);
            _sceneView.Roll(-15f);
            Assert.That(_sceneView.rotation.eulerAngles, Is.EqualTo(new Vector3(0f, 90f, 345f)).Using(_comparer));
        }

        [Test]
        public void Roll_top_left()
        {
            _sceneView.SetDirection(Vector3.down);
            _sceneView.Roll(-15f);
            Assert.That(_sceneView.rotation.eulerAngles, Is.EqualTo(new Vector3(90f, 195f, 0f)).Using(_comparer));
        }

        [Test]
        public void Pan_front_to_up()
        {
            _sceneView.SetDirection(Vector3.back);
            _sceneView.Pan(Vector3.up, 0.2f);
            Assert.That(_sceneView.pivot, Is.EqualTo(new Vector3(0f, 2f, 0f)).Using(_comparer));
        }

        [Test]
        public void Pan_back_to_left()
        {
            _sceneView.SetDirection(Vector3.forward);
            _sceneView.Pan(Vector3.left, 0.2f);
            Assert.That(_sceneView.pivot, Is.EqualTo(new Vector3(-2f, 0f, 0f)).Using(_comparer));
        }

        [Test]
        public void Pan_right_to_left()
        {
            _sceneView.SetDirection(Vector3.right);
            _sceneView.Pan(Vector3.left, 0.2f);
            Assert.That(_sceneView.pivot, Is.EqualTo(new Vector3(0f, 0f, 2f)).Using(_comparer));
        }

        [Test]
        public void Pan_bottom_to_down()
        {
            _sceneView.SetDirection(Vector3.up);
            _sceneView.Pan(Vector3.down, 0.2f);
            Assert.That(_sceneView.pivot, Is.EqualTo(new Vector3(0f, 0f, -2f)).Using(_comparer));
        }

        [Test]
        public void Zoom_in()
        {
            _sceneView.Zoom(2f);
            Assert.That(_sceneView.size, Is.EqualTo(8f));
        }

        [Test]
        public void Zoom_in_toZero()
        {
            _sceneView.Zoom(10f);
            Assert.That(_sceneView.size, Is.EqualTo(0f));
        }

        [Test]
        public void Zoom_in_notBeMinus()
        {
            _sceneView.Zoom(11f);
            Assert.That(_sceneView.size, Is.EqualTo(10f));
        }

        [Test]
        public void Zoom_out()
        {
            _sceneView.Zoom(-2f);
            Assert.That(_sceneView.size, Is.EqualTo(12f));
        }

        [Test]
        public void ToggleOrthographicProjection_toggleOnce()
        {
            _sceneView.ToggleOrthographicProjection();
            Assert.That(_sceneView.orthographic, Is.EqualTo(true));
        }

        [Test]
        public void ToggleOrthographicProjection_toggleTwice()
        {
            _sceneView.ToggleOrthographicProjection();
            _sceneView.ToggleOrthographicProjection(); // twice
            Assert.That(_sceneView.orthographic, Is.EqualTo(false));
        }
    }
}
