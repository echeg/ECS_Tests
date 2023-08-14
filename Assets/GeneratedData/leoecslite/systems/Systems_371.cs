using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System371 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component324> _p1;
EcsPool<Component344> _p2;
EcsPool<Component201> _p3;
EcsPool<Component209> _p4;
EcsPool<Component361> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component324>().Inc<Component344>().Inc<Component201>().Inc<Component209>().End();
   _p1 = _world.GetPool<Component324>();
   _p2 = _world.GetPool<Component344>();
   _p3 = _world.GetPool<Component201>();
   _p4 = _world.GetPool<Component209>();
   _pl0 = _world.GetPool<Component361>();
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
