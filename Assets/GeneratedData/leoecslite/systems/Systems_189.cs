using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System189 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component220> _p1;
EcsPool<Component363> _p2;
EcsPool<Component137> _p3;
EcsPool<Component361> _p4;
EcsPool<Component181> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component220>().Inc<Component363>().Inc<Component137>().Inc<Component361>().End();
   _p1 = _world.GetPool<Component220>();
   _p2 = _world.GetPool<Component363>();
   _p3 = _world.GetPool<Component137>();
   _p4 = _world.GetPool<Component361>();
   _pl0 = _world.GetPool<Component181>();
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
