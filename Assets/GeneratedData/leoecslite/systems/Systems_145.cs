using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System145 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component88> _p1;
EcsPool<Component159> _p2;
EcsPool<Component50> _p3;
EcsPool<Component339> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component88>().Inc<Component159>().Inc<Component50>().End();
   _p1 = _world.GetPool<Component88>();
   _p2 = _world.GetPool<Component159>();
   _p3 = _world.GetPool<Component50>();
   _pl0 = _world.GetPool<Component339>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_p1.Has(entity))
   {
    _p1.Del(entity);
   }
   else
   {
    _p1.Add(entity);
   }
  }
 }
}

}
