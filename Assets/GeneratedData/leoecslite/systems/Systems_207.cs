using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System207 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component145> _p1;
EcsPool<Component425> _p2;
EcsPool<Component293> _p3;
EcsPool<Component39> _p4;
EcsPool<Component132> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component145>().Inc<Component425>().Inc<Component293>().Inc<Component39>().End();
   _p1 = _world.GetPool<Component145>();
   _p2 = _world.GetPool<Component425>();
   _p3 = _world.GetPool<Component293>();
   _p4 = _world.GetPool<Component39>();
   _pl0 = _world.GetPool<Component132>();
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
