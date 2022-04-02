using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System187 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component444> _p1;
EcsPool<Component164> _p2;
EcsPool<Component71> _p3;
EcsPool<Component219> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component444>().Inc<Component164>().Inc<Component71>().Inc<Component219>().End();
   _p1 = _world.GetPool<Component444>();
   _p2 = _world.GetPool<Component164>();
   _p3 = _world.GetPool<Component71>();
   _p4 = _world.GetPool<Component219>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
