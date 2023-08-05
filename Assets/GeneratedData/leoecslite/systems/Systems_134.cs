using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System134 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component31> _p1;
EcsPool<Component499> _p2;
EcsPool<Component60> _p3;
EcsPool<Component3> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component31>().Inc<Component499>().Inc<Component60>().End();
   _p1 = _world.GetPool<Component31>();
   _p2 = _world.GetPool<Component499>();
   _p3 = _world.GetPool<Component60>();
   _pl0 = _world.GetPool<Component3>();
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
