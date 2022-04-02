using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System101 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component273> _p1;
EcsPool<Component312> _p2;
EcsPool<Component357> _p3;
EcsPool<Component346> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component273>().Inc<Component312>().Inc<Component357>().Inc<Component346>().End();
   _p1 = _world.GetPool<Component273>();
   _p2 = _world.GetPool<Component312>();
   _p3 = _world.GetPool<Component357>();
   _p4 = _world.GetPool<Component346>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
