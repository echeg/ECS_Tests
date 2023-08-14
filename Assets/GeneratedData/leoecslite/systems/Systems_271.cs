using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System271 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component385> _p1;
EcsPool<Component408> _p2;
EcsPool<Component435> _p3;
EcsPool<Component7> _p4;
EcsPool<Component457> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component385>().Inc<Component408>().Inc<Component435>().Inc<Component7>().End();
   _p1 = _world.GetPool<Component385>();
   _p2 = _world.GetPool<Component408>();
   _p3 = _world.GetPool<Component435>();
   _p4 = _world.GetPool<Component7>();
   _pl0 = _world.GetPool<Component457>();
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
