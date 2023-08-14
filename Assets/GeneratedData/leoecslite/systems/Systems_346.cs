using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System346 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component325> _p1;
EcsPool<Component84> _p2;
EcsPool<Component484> _p3;
EcsPool<Component311> _p4;
EcsPool<Component350> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component325>().Inc<Component84>().Inc<Component484>().Inc<Component311>().End();
   _p1 = _world.GetPool<Component325>();
   _p2 = _world.GetPool<Component84>();
   _p3 = _world.GetPool<Component484>();
   _p4 = _world.GetPool<Component311>();
   _pl0 = _world.GetPool<Component350>();
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
