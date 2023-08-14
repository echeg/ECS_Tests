using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System326 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component384> _p1;
EcsPool<Component380> _p2;
EcsPool<Component65> _p3;
EcsPool<Component163> _p4;
EcsPool<Component20> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component384>().Inc<Component380>().Inc<Component65>().Inc<Component163>().End();
   _p1 = _world.GetPool<Component384>();
   _p2 = _world.GetPool<Component380>();
   _p3 = _world.GetPool<Component65>();
   _p4 = _world.GetPool<Component163>();
   _pl0 = _world.GetPool<Component20>();
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
