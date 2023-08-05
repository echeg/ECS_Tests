using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System228 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component315> _p1;
EcsPool<Component175> _p2;
EcsPool<Component164> _pl0;
EcsPool<Component64> _pl1;
EcsPool<Component99> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component315>().Inc<Component175>().End();
   _p1 = _world.GetPool<Component315>();
   _p2 = _world.GetPool<Component175>();
   _pl0 = _world.GetPool<Component164>();
   _pl1 = _world.GetPool<Component64>();
   _pl2 = _world.GetPool<Component99>();
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
  }
 }
}

}
