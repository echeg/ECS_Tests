using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System168 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component485> _p1;
EcsPool<Component389> _p2;
EcsPool<Component264> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component485>().Inc<Component389>().Inc<Component264>().End();
   _p1 = _world.GetPool<Component485>();
   _p2 = _world.GetPool<Component389>();
   _p3 = _world.GetPool<Component264>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
