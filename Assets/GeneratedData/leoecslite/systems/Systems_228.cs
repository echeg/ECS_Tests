using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System228 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component141> _p1;
EcsPool<Component329> _p2;
EcsPool<Component167> _p3;
EcsPool<Component227> _p4;
EcsPool<Component457> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component141>().Inc<Component329>().Inc<Component167>().Inc<Component227>().End();
   _p1 = _world.GetPool<Component141>();
   _p2 = _world.GetPool<Component329>();
   _p3 = _world.GetPool<Component167>();
   _p4 = _world.GetPool<Component227>();
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
