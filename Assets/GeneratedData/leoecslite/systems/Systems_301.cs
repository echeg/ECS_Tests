using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System301 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component309> _p1;
EcsPool<Component301> _p2;
EcsPool<Component249> _p3;
EcsPool<Component475> _p4;
EcsPool<Component410> _pl0;
EcsPool<Component415> _pl1;
EcsPool<Component426> _pl2;
EcsPool<Component167> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component309>().Inc<Component301>().Inc<Component249>().Inc<Component475>().End();
   _p1 = _world.GetPool<Component309>();
   _p2 = _world.GetPool<Component301>();
   _p3 = _world.GetPool<Component249>();
   _p4 = _world.GetPool<Component475>();
   _pl0 = _world.GetPool<Component410>();
   _pl1 = _world.GetPool<Component415>();
   _pl2 = _world.GetPool<Component426>();
   _pl3 = _world.GetPool<Component167>();
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
