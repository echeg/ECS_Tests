using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System38 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component221> _p1;
EcsPool<Component161> _p2;
EcsPool<Component73> _pl0;
EcsPool<Component149> _pl1;
EcsPool<Component377> _pl2;
EcsPool<Component156> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component221>().Inc<Component161>().End();
   _p1 = _world.GetPool<Component221>();
   _p2 = _world.GetPool<Component161>();
   _pl0 = _world.GetPool<Component73>();
   _pl1 = _world.GetPool<Component149>();
   _pl2 = _world.GetPool<Component377>();
   _pl3 = _world.GetPool<Component156>();
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
