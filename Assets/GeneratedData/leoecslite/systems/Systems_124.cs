using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System124 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component126> _p1;
EcsPool<Component495> _p2;
EcsPool<Component464> _p3;
EcsPool<Component50> _p4;
EcsPool<Component116> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component126>().Inc<Component495>().Inc<Component464>().Inc<Component50>().End();
   _p1 = _world.GetPool<Component126>();
   _p2 = _world.GetPool<Component495>();
   _p3 = _world.GetPool<Component464>();
   _p4 = _world.GetPool<Component50>();
   _pl0 = _world.GetPool<Component116>();
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
