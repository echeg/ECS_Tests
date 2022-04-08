using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System57 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component455> _p1;
EcsPool<Component243> _p2;
EcsPool<Component14> _p3;
EcsPool<Component370> _p4;
EcsPool<Component284> _pl0;
EcsPool<Component491> _pl1;
EcsPool<Component177> _pl2;
EcsPool<Component142> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component455>().Inc<Component243>().Inc<Component14>().Inc<Component370>().End();
   _p1 = _world.GetPool<Component455>();
   _p2 = _world.GetPool<Component243>();
   _p3 = _world.GetPool<Component14>();
   _p4 = _world.GetPool<Component370>();
   _pl0 = _world.GetPool<Component284>();
   _pl1 = _world.GetPool<Component491>();
   _pl2 = _world.GetPool<Component177>();
   _pl3 = _world.GetPool<Component142>();
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
