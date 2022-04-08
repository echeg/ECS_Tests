using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System95 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component408> _p1;
EcsPool<Component12> _p2;
EcsPool<Component157> _p3;
EcsPool<Component224> _pl0;
EcsPool<Component325> _pl1;
EcsPool<Component347> _pl2;
EcsPool<Component494> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component408>().Inc<Component12>().Inc<Component157>().End();
   _p1 = _world.GetPool<Component408>();
   _p2 = _world.GetPool<Component12>();
   _p3 = _world.GetPool<Component157>();
   _pl0 = _world.GetPool<Component224>();
   _pl1 = _world.GetPool<Component325>();
   _pl2 = _world.GetPool<Component347>();
   _pl3 = _world.GetPool<Component494>();
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
