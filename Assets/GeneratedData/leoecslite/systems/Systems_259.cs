using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System259 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component56> _p1;
EcsPool<Component493> _p2;
EcsPool<Component117> _p3;
EcsPool<Component466> _p4;
EcsPool<Component21> _pl0;
EcsPool<Component101> _pl1;
EcsPool<Component136> _pl2;
EcsPool<Component88> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component56>().Inc<Component493>().Inc<Component117>().Inc<Component466>().End();
   _p1 = _world.GetPool<Component56>();
   _p2 = _world.GetPool<Component493>();
   _p3 = _world.GetPool<Component117>();
   _p4 = _world.GetPool<Component466>();
   _pl0 = _world.GetPool<Component21>();
   _pl1 = _world.GetPool<Component101>();
   _pl2 = _world.GetPool<Component136>();
   _pl3 = _world.GetPool<Component88>();
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
