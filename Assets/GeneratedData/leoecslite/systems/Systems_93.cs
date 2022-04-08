using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System93 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component54> _p1;
EcsPool<Component356> _p2;
EcsPool<Component176> _p3;
EcsPool<Component443> _pl0;
EcsPool<Component267> _pl1;
EcsPool<Component118> _pl2;
EcsPool<Component451> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component54>().Inc<Component356>().Inc<Component176>().End();
   _p1 = _world.GetPool<Component54>();
   _p2 = _world.GetPool<Component356>();
   _p3 = _world.GetPool<Component176>();
   _pl0 = _world.GetPool<Component443>();
   _pl1 = _world.GetPool<Component267>();
   _pl2 = _world.GetPool<Component118>();
   _pl3 = _world.GetPool<Component451>();
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
