using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System171 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component187> _p1;
EcsPool<Component105> _p2;
EcsPool<Component243> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component187>().Inc<Component105>().Inc<Component243>().End();
   _p1 = _world.GetPool<Component187>();
   _p2 = _world.GetPool<Component105>();
   _p3 = _world.GetPool<Component243>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
