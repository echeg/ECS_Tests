using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System48 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component161> _p1;
EcsPool<Component450> _p2;
EcsPool<Component192> _p3;
EcsPool<Component41> _pl0;
EcsPool<Component237> _pl1;
EcsPool<Component455> _pl2;
EcsPool<Component23> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component161>().Inc<Component450>().Inc<Component192>().End();
   _p1 = _world.GetPool<Component161>();
   _p2 = _world.GetPool<Component450>();
   _p3 = _world.GetPool<Component192>();
   _pl0 = _world.GetPool<Component41>();
   _pl1 = _world.GetPool<Component237>();
   _pl2 = _world.GetPool<Component455>();
   _pl3 = _world.GetPool<Component23>();
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
