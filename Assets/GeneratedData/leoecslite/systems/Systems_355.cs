using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System355 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component242> _p1;
EcsPool<Component33> _p2;
EcsPool<Component24> _p3;
EcsPool<Component339> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component242>().Inc<Component33>().Inc<Component24>().End();
   _p1 = _world.GetPool<Component242>();
   _p2 = _world.GetPool<Component33>();
   _p3 = _world.GetPool<Component24>();
   _pl0 = _world.GetPool<Component339>();
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
