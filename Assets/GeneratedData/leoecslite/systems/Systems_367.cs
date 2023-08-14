using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System367 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component34> _p1;
EcsPool<Component258> _p2;
EcsPool<Component141> _p3;
EcsPool<Component421> _p4;
EcsPool<Component160> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component34>().Inc<Component258>().Inc<Component141>().Inc<Component421>().End();
   _p1 = _world.GetPool<Component34>();
   _p2 = _world.GetPool<Component258>();
   _p3 = _world.GetPool<Component141>();
   _p4 = _world.GetPool<Component421>();
   _pl0 = _world.GetPool<Component160>();
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
