using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System104 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component153> _p1;
EcsPool<Component340> _p2;
EcsPool<Component422> _p3;
EcsPool<Component444> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component153>().Inc<Component340>().Inc<Component422>().End();
   _p1 = _world.GetPool<Component153>();
   _p2 = _world.GetPool<Component340>();
   _p3 = _world.GetPool<Component422>();
   _pl0 = _world.GetPool<Component444>();
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
