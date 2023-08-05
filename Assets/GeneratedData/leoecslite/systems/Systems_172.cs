using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System172 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component53> _p1;
EcsPool<Component391> _p2;
EcsPool<Component163> _p3;
EcsPool<Component347> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component53>().Inc<Component391>().Inc<Component163>().End();
   _p1 = _world.GetPool<Component53>();
   _p2 = _world.GetPool<Component391>();
   _p3 = _world.GetPool<Component163>();
   _pl0 = _world.GetPool<Component347>();
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
