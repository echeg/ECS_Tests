using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System205 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component463> _p1;
EcsPool<Component197> _p2;
EcsPool<Component333> _p3;
EcsPool<Component338> _p4;
EcsPool<Component348> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component463>().Inc<Component197>().Inc<Component333>().Inc<Component338>().End();
   _p1 = _world.GetPool<Component463>();
   _p2 = _world.GetPool<Component197>();
   _p3 = _world.GetPool<Component333>();
   _p4 = _world.GetPool<Component338>();
   _pl0 = _world.GetPool<Component348>();
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
