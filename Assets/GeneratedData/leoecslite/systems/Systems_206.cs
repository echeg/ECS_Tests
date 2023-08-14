using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System206 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component372> _p1;
EcsPool<Component141> _p2;
EcsPool<Component387> _p3;
EcsPool<Component87> _p4;
EcsPool<Component60> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component372>().Inc<Component141>().Inc<Component387>().Inc<Component87>().End();
   _p1 = _world.GetPool<Component372>();
   _p2 = _world.GetPool<Component141>();
   _p3 = _world.GetPool<Component387>();
   _p4 = _world.GetPool<Component87>();
   _pl0 = _world.GetPool<Component60>();
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
