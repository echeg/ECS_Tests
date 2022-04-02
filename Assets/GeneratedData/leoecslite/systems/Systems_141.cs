using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System141 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component119> _p1;
EcsPool<Component140> _p2;
EcsPool<Component120> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component119>().Inc<Component140>().Inc<Component120>().End();
   _p1 = _world.GetPool<Component119>();
   _p2 = _world.GetPool<Component140>();
   _p3 = _world.GetPool<Component120>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
