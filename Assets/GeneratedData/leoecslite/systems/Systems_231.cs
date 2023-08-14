using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System231 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component74> _p1;
EcsPool<Component465> _p2;
EcsPool<Component45> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component74>().Inc<Component465>().End();
   _p1 = _world.GetPool<Component74>();
   _p2 = _world.GetPool<Component465>();
   _pl0 = _world.GetPool<Component45>();
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
