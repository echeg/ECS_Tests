using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System134 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component277> _p1;
EcsPool<Component6> _p2;
EcsPool<Component495> _p3;
EcsPool<Component415> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component277>().Inc<Component6>().Inc<Component495>().Inc<Component415>().End();
   _p1 = _world.GetPool<Component277>();
   _p2 = _world.GetPool<Component6>();
   _p3 = _world.GetPool<Component495>();
   _p4 = _world.GetPool<Component415>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
