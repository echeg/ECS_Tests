using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System172 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component467> _p1;
EcsPool<Component382> _p2;
EcsPool<Component17> _p3;
EcsPool<Component244> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component467>().Inc<Component382>().Inc<Component17>().Inc<Component244>().End();
   _p1 = _world.GetPool<Component467>();
   _p2 = _world.GetPool<Component382>();
   _p3 = _world.GetPool<Component17>();
   _p4 = _world.GetPool<Component244>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
