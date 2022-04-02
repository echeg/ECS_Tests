using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System143 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component498> _p1;
EcsPool<Component61> _p2;
EcsPool<Component257> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component498>().Inc<Component61>().Inc<Component257>().End();
   _p1 = _world.GetPool<Component498>();
   _p2 = _world.GetPool<Component61>();
   _p3 = _world.GetPool<Component257>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
