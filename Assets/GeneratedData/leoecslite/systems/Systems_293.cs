using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System293 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component106> _p1;
EcsPool<Component425> _p2;
EcsPool<Component373> _p3;
EcsPool<Component270> _p4;
EcsPool<Component70> _pl0;
EcsPool<Component335> _pl1;
EcsPool<Component213> _pl2;
EcsPool<Component418> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component106>().Inc<Component425>().Inc<Component373>().Inc<Component270>().End();
   _p1 = _world.GetPool<Component106>();
   _p2 = _world.GetPool<Component425>();
   _p3 = _world.GetPool<Component373>();
   _p4 = _world.GetPool<Component270>();
   _pl0 = _world.GetPool<Component70>();
   _pl1 = _world.GetPool<Component335>();
   _pl2 = _world.GetPool<Component213>();
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
