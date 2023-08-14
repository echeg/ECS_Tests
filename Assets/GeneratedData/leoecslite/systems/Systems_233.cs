using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System233 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component352> _p1;
EcsPool<Component432> _p2;
EcsPool<Component276> _p3;
EcsPool<Component411> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component352>().Inc<Component432>().Inc<Component276>().End();
   _p1 = _world.GetPool<Component352>();
   _p2 = _world.GetPool<Component432>();
   _p3 = _world.GetPool<Component276>();
   _pl0 = _world.GetPool<Component411>();
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
