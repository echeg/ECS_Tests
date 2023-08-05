using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System260 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component338> _p1;
EcsPool<Component374> _p2;
EcsPool<Component423> _p3;
EcsPool<Component424> _pl0;
EcsPool<Component354> _pl1;
EcsPool<Component337> _pl2;
EcsPool<Component126> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component338>().Inc<Component374>().Inc<Component423>().End();
   _p1 = _world.GetPool<Component338>();
   _p2 = _world.GetPool<Component374>();
   _p3 = _world.GetPool<Component423>();
   _pl0 = _world.GetPool<Component424>();
   _pl1 = _world.GetPool<Component354>();
   _pl2 = _world.GetPool<Component337>();
   _pl3 = _world.GetPool<Component126>();
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
