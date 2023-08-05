using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System207 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component386> _p1;
EcsPool<Component133> _p2;
EcsPool<Component75> _p3;
EcsPool<Component301> _p4;
EcsPool<Component175> _pl0;
EcsPool<Component159> _pl1;
EcsPool<Component235> _pl2;
EcsPool<Component390> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component386>().Inc<Component133>().Inc<Component75>().Inc<Component301>().End();
   _p1 = _world.GetPool<Component386>();
   _p2 = _world.GetPool<Component133>();
   _p3 = _world.GetPool<Component75>();
   _p4 = _world.GetPool<Component301>();
   _pl0 = _world.GetPool<Component175>();
   _pl1 = _world.GetPool<Component159>();
   _pl2 = _world.GetPool<Component235>();
   _pl3 = _world.GetPool<Component390>();
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
