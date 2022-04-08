using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System15 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component480> _p1;
EcsPool<Component214> _p2;
EcsPool<Component24> _p3;
EcsPool<Component340> _p4;
EcsPool<Component469> _pl0;
EcsPool<Component37> _pl1;
EcsPool<Component77> _pl2;
EcsPool<Component257> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component480>().Inc<Component214>().Inc<Component24>().Inc<Component340>().End();
   _p1 = _world.GetPool<Component480>();
   _p2 = _world.GetPool<Component214>();
   _p3 = _world.GetPool<Component24>();
   _p4 = _world.GetPool<Component340>();
   _pl0 = _world.GetPool<Component469>();
   _pl1 = _world.GetPool<Component37>();
   _pl2 = _world.GetPool<Component77>();
   _pl3 = _world.GetPool<Component257>();
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
