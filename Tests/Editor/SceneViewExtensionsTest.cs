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
        public void ToggleOrthographicProjection_toggleOnce()
        {
            var orthographic = _sceneView.orthographic;
            _sceneView.ToggleOrthographicProjection();
            Assert.That(_sceneView.orthographic, Is.EqualTo(!orthographic)); // inversed
        }

        [Test]
        public void ToggleOrthographicProjection_toggleTwice()
        {
            var orthographic = _sceneView.orthographic;
            _sceneView.ToggleOrthographicProjection();
            _sceneView.ToggleOrthographicProjection(); // twice
            Assert.That(_sceneView.orthographic, Is.EqualTo(orthographic)); // origin
        }
    }
}
