using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System271 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component227> _p1;
EcsPool<Component419> _p2;
EcsPool<Component33> _p3;
EcsPool<Component475> _pl0;
EcsPool<Component256> _pl1;
EcsPool<Component364> _pl2;
EcsPool<Component418> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component227>().Inc<Component419>().Inc<Component33>().End();
   _p1 = _world.GetPool<Component227>();
   _p2 = _world.GetPool<Component419>();
   _p3 = _world.GetPool<Component33>();
   _pl0 = _world.GetPool<Component475>();
   _pl1 = _world.GetPool<Component256>();
   _pl2 = _world.GetPool<Component364>();
   _pl3 = _world.GetPool<Component418>();
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
