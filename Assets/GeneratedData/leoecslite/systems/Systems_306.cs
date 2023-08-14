using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System306 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component447> _p1;
EcsPool<Component215> _p2;
EcsPool<Component374> _p3;
EcsPool<Component499> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component447>().Inc<Component215>().Inc<Component374>().End();
   _p1 = _world.GetPool<Component447>();
   _p2 = _world.GetPool<Component215>();
   _p3 = _world.GetPool<Component374>();
   _pl0 = _world.GetPool<Component499>();
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
