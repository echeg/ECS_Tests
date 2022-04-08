using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System88 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component307> _p1;
EcsPool<Component98> _p2;
EcsPool<Component187> _p3;
EcsPool<Component39> _p4;
EcsPool<Component127> _pl0;
EcsPool<Component377> _pl1;
EcsPool<Component353> _pl2;
EcsPool<Component385> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component307>().Inc<Component98>().Inc<Component187>().Inc<Component39>().End();
   _p1 = _world.GetPool<Component307>();
   _p2 = _world.GetPool<Component98>();
   _p3 = _world.GetPool<Component187>();
   _p4 = _world.GetPool<Component39>();
   _pl0 = _world.GetPool<Component127>();
   _pl1 = _world.GetPool<Component377>();
   _pl2 = _world.GetPool<Component353>();
   _pl3 = _world.GetPool<Component385>();
 }
 public void Run (EcsSystems systems) {
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
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl3.Has(entity))
   {
    q+=1;
    var component1 = _pl3.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
