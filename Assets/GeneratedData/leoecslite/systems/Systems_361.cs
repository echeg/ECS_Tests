using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System361 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component89> _p1;
EcsPool<Component266> _p2;
EcsPool<Component105> _p3;
EcsPool<Component448> _p4;
EcsPool<Component181> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component89>().Inc<Component266>().Inc<Component105>().Inc<Component448>().End();
   _p1 = _world.GetPool<Component89>();
   _p2 = _world.GetPool<Component266>();
   _p3 = _world.GetPool<Component105>();
   _p4 = _world.GetPool<Component448>();
   _pl0 = _world.GetPool<Component181>();
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
