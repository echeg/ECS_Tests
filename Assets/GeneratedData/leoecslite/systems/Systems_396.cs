using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System396 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component180> _p1;
EcsPool<Component230> _p2;
EcsPool<Component329> _p3;
EcsPool<Component101> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component180>().Inc<Component230>().Inc<Component329>().End();
   _p1 = _world.GetPool<Component180>();
   _p2 = _world.GetPool<Component230>();
   _p3 = _world.GetPool<Component329>();
   _pl0 = _world.GetPool<Component101>();
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
