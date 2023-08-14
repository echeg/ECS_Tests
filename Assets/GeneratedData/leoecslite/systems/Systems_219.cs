using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System219 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component53> _p1;
EcsPool<Component499> _p2;
EcsPool<Component419> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component53>().Inc<Component499>().End();
   _p1 = _world.GetPool<Component53>();
   _p2 = _world.GetPool<Component499>();
   _pl0 = _world.GetPool<Component419>();
 }
 public void Run (IEcsSystems systems) {
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
