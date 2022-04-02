using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System133 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component81> _p1;
EcsPool<Component63> _p2;
EcsPool<Component150> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component81>().Inc<Component63>().Inc<Component150>().End();
   _p1 = _world.GetPool<Component81>();
   _p2 = _world.GetPool<Component63>();
   _p3 = _world.GetPool<Component150>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
