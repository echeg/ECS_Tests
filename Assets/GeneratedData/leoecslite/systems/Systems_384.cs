using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System384 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component456> _p1;
EcsPool<Component393> _p2;
EcsPool<Component231> _p3;
EcsPool<Component394> _p4;
EcsPool<Component241> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component456>().Inc<Component393>().Inc<Component231>().Inc<Component394>().End();
   _p1 = _world.GetPool<Component456>();
   _p2 = _world.GetPool<Component393>();
   _p3 = _world.GetPool<Component231>();
   _p4 = _world.GetPool<Component394>();
   _pl0 = _world.GetPool<Component241>();
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
