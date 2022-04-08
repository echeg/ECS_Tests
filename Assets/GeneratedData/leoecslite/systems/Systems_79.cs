using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System79 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component76> _p1;
EcsPool<Component462> _p2;
EcsPool<Component139> _p3;
EcsPool<Component396> _pl0;
EcsPool<Component379> _pl1;
EcsPool<Component426> _pl2;
EcsPool<Component261> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component76>().Inc<Component462>().Inc<Component139>().End();
   _p1 = _world.GetPool<Component76>();
   _p2 = _world.GetPool<Component462>();
   _p3 = _world.GetPool<Component139>();
   _pl0 = _world.GetPool<Component396>();
   _pl1 = _world.GetPool<Component379>();
   _pl2 = _world.GetPool<Component426>();
   _pl3 = _world.GetPool<Component261>();
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
