using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System452 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component476> _p1;
EcsPool<Component250> _p2;
EcsPool<Component166> _p3;
EcsPool<Component340> _p4;
EcsPool<Component209> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component476>().Inc<Component250>().Inc<Component166>().Inc<Component340>().End();
   _p1 = _world.GetPool<Component476>();
   _p2 = _world.GetPool<Component250>();
   _p3 = _world.GetPool<Component166>();
   _p4 = _world.GetPool<Component340>();
   _pl0 = _world.GetPool<Component209>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
