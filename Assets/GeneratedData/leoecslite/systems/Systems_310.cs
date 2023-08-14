using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System310 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component110> _p1;
EcsPool<Component482> _p2;
EcsPool<Component113> _p3;
EcsPool<Component209> _p4;
EcsPool<Component297> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component110>().Inc<Component482>().Inc<Component113>().Inc<Component209>().End();
   _p1 = _world.GetPool<Component110>();
   _p2 = _world.GetPool<Component482>();
   _p3 = _world.GetPool<Component113>();
   _p4 = _world.GetPool<Component209>();
   _pl0 = _world.GetPool<Component297>();
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
