using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System286 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component455> _p1;
EcsPool<Component96> _p2;
EcsPool<Component179> _p3;
EcsPool<Component50> _p4;
EcsPool<Component229> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component455>().Inc<Component96>().Inc<Component179>().Inc<Component50>().End();
   _p1 = _world.GetPool<Component455>();
   _p2 = _world.GetPool<Component96>();
   _p3 = _world.GetPool<Component179>();
   _p4 = _world.GetPool<Component50>();
   _pl0 = _world.GetPool<Component229>();
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
