using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System213 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component461> _p1;
EcsPool<Component155> _p2;
EcsPool<Component22> _p3;
EcsPool<Component434> _p4;
EcsPool<Component214> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component461>().Inc<Component155>().Inc<Component22>().Inc<Component434>().End();
   _p1 = _world.GetPool<Component461>();
   _p2 = _world.GetPool<Component155>();
   _p3 = _world.GetPool<Component22>();
   _p4 = _world.GetPool<Component434>();
   _pl0 = _world.GetPool<Component214>();
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
