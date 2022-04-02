using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System199 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component388> _p1;
EcsPool<Component276> _p2;
EcsPool<Component253> _p3;
EcsPool<Component441> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component388>().Inc<Component276>().Inc<Component253>().Inc<Component441>().End();
   _p1 = _world.GetPool<Component388>();
   _p2 = _world.GetPool<Component276>();
   _p3 = _world.GetPool<Component253>();
   _p4 = _world.GetPool<Component441>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
