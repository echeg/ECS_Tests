using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System127 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component72> _p1;
EcsPool<Component404> _p2;
EcsPool<Component42> _p3;
EcsPool<Component233> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component72>().Inc<Component404>().Inc<Component42>().Inc<Component233>().End();
   _p1 = _world.GetPool<Component72>();
   _p2 = _world.GetPool<Component404>();
   _p3 = _world.GetPool<Component42>();
   _p4 = _world.GetPool<Component233>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
