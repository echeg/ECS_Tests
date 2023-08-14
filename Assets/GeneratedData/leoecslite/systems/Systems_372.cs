using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System372 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component388> _p1;
EcsPool<Component150> _p2;
EcsPool<Component192> _p3;
EcsPool<Component352> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component388>().Inc<Component150>().Inc<Component192>().End();
   _p1 = _world.GetPool<Component388>();
   _p2 = _world.GetPool<Component150>();
   _p3 = _world.GetPool<Component192>();
   _pl0 = _world.GetPool<Component352>();
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
