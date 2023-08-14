using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System284 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component474> _p1;
EcsPool<Component334> _p2;
EcsPool<Component374> _p3;
EcsPool<Component179> _p4;
EcsPool<Component466> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component474>().Inc<Component334>().Inc<Component374>().Inc<Component179>().End();
   _p1 = _world.GetPool<Component474>();
   _p2 = _world.GetPool<Component334>();
   _p3 = _world.GetPool<Component374>();
   _p4 = _world.GetPool<Component179>();
   _pl0 = _world.GetPool<Component466>();
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
