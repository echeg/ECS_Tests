using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System253 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component402> _p1;
EcsPool<Component66> _p2;
EcsPool<Component374> _p3;
EcsPool<Component231> _p4;
EcsPool<Component381> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component402>().Inc<Component66>().Inc<Component374>().Inc<Component231>().End();
   _p1 = _world.GetPool<Component402>();
   _p2 = _world.GetPool<Component66>();
   _p3 = _world.GetPool<Component374>();
   _p4 = _world.GetPool<Component231>();
   _pl0 = _world.GetPool<Component381>();
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