using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System83 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component88> _p1;
EcsPool<Component297> _p2;
EcsPool<Component219> _pl0;
EcsPool<Component392> _pl1;
EcsPool<Component498> _pl2;
EcsPool<Component353> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component88>().Inc<Component297>().End();
   _p1 = _world.GetPool<Component88>();
   _p2 = _world.GetPool<Component297>();
   _pl0 = _world.GetPool<Component219>();
   _pl1 = _world.GetPool<Component392>();
   _pl2 = _world.GetPool<Component498>();
   _pl3 = _world.GetPool<Component353>();
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