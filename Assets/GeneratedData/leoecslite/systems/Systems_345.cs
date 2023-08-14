using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System345 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component76> _p1;
EcsPool<Component363> _p2;
EcsPool<Component51> _p3;
EcsPool<Component298> _p4;
EcsPool<Component76> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component76>().Inc<Component363>().Inc<Component51>().Inc<Component298>().End();
   _p1 = _world.GetPool<Component76>();
   _p2 = _world.GetPool<Component363>();
   _p3 = _world.GetPool<Component51>();
   _p4 = _world.GetPool<Component298>();
   _pl0 = _world.GetPool<Component76>();
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
