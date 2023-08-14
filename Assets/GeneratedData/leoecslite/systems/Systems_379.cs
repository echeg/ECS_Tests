using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System379 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component204> _p1;
EcsPool<Component74> _p2;
EcsPool<Component128> _p3;
EcsPool<Component22> _p4;
EcsPool<Component277> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component204>().Inc<Component74>().Inc<Component128>().Inc<Component22>().End();
   _p1 = _world.GetPool<Component204>();
   _p2 = _world.GetPool<Component74>();
   _p3 = _world.GetPool<Component128>();
   _p4 = _world.GetPool<Component22>();
   _pl0 = _world.GetPool<Component277>();
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
